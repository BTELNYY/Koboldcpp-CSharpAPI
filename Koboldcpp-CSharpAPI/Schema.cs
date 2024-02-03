using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Koboldcpp_CSharpAPI
{
    public class AddSentenceSpacingSettings
    {
        public bool value { get; set; }
    }

    public class AuthorsNoteDepthSetting
    {
        [NonSerialized]
        private int _value = 1;

        public int value
        {
            set
            {
                if (value > 5)
                {
                    _value = 5;
                    return;
                }
                if (value < 1)
                {
                    _value = 1;
                    return;
                }
                _value = value;
            }
            get
            {
                return _value;
            }
        }
    }

    public class AuthorsNoteSetting
    {
        public string value { get; set; } = string.Empty;
    }

    public class AuthorsNoteTemplateSetting
    {
        public string value { get; set; } = string.Empty;
    }

    public class BasicBoolean
    {
        public bool value { get; set; }
    }

    public class BasicBooleanResult
    {
        public bool result { get; set; } 
    }

    public class BasicError
    {
        public string msg { get; set; } = string.Empty;

        public string type { get; set; } = string.Empty;
    }

    public class BasicResult
    {
        public BasicResult result { get; set; } = new BasicResult();
    }

    public class BasicResultInner
    {
        public string result { get; set; } = string.Empty;
    }

    public class BasicResults
    {
        public BasicResultInner[] results { get; set; } = Array.Empty<BasicResultInner>();
    }

    public class BasicString
    {
        public string value { get; set; } = string.Empty;
    }

    public class BasicUID
    {
        public int uid { get; set; }
    }

    public class Empty
    {

    }

    public class GenerationInput
    {
        public bool disable_input_formatting { get; set; } = true;

        public bool disable_output_formatting { get; set; } = true;

        public bool frmtadsnsp { get; set; }

        public bool frmtrmblln { get; set; }

        public bool frmtrmspch { get; set; }

        public bool frmttriminc { get; set; }

        [NonSerialized]
        private int _max_context_length = 1;
        public int max_context_length
        {
            get
            {
                return _max_context_length;
            }
            set
            {
                _max_context_length = Math.Max(value, 1);
            }
        }

        [NonSerialized]
        private int _max_length = 1;
        public int max_length
        {
            get
            {
                return _max_length;
            }
            set
            {
                _max_length = Math.Max(value, 1);
            }
        }

        [NonSerialized]
        private int _n = 1;
        public int n
        {
            get
            {
                return _n;
            }
            set
            {
                if(value > 5)
                {
                    _n = 5;
                    return;
                }
                if(value < 1)
                {
                    _n = 1;
                    return;
                }
                _n = value;
            }
        }

        [NonSerialized]
        private string _prompt = string.Empty;
        public string prompt
        {
            get
            {
                return _prompt;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidOperationException("Prompt cannot be null");
                }
                _prompt = value;
            }
        }

        public bool quiet { get; set; }

        [NonSerialized]
        private int _rep_pen = 1;
        public int rep_pen
        {
            get
            {
                return _rep_pen;
            }
            set
            {
                _rep_pen = Math.Max(1, value);
            }
        }

        [NonSerialized]
        private int _rep_pen_range = 0;
        public int rep_pen_range
        {
            get
            {
                return _rep_pen_range;
            }
            set
            {
                _rep_pen_range = Math.Max(0, value);
            }
        }

        [NonSerialized]
        private int _rep_pen_slope = 0;
        public int rep_pen_slope
        {
            get
            {
                return _rep_pen_slope;
            }
            set
            {
                _rep_pen_slope = Math.Max(0, value);
            }
        }

        public bool sampler_full_determinism { get; set; }

        public int[] sampler_order { get; set; } = Array.Empty<int>();

        public long sampler_seed { get; set; }

        [NonSerialized]
        private bool _singleline;
        public bool singleline
        {
            get
            {
                return _singleline;
            }
            set
            {
                if(disable_input_formatting)
                {
                    return;
                }
                else
                {
                    _singleline = value;
                }
            }
        }

        [NonSerialized]
        private string _soft_prompt = string.Empty;
        public string soft_prompt
        {
            get
            {
                return _soft_prompt;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    return;
                }
                Regex regex = new Regex("^[^/\\]*$]");
                string val = regex.Replace(value, string.Empty);
                _soft_prompt = val;
            }
        }

        public string[] stop_sequence = Array.Empty<string>();

        [NonSerialized]
        private long _temperature = 0;
        public long temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = Math.Max(value, 0);
            }
        }

        [NonSerialized]
        private float _tfs = 0;
        public float tfs
        {
            get
            {
                return _tfs;
            }
            set
            {
                _tfs = MathF.Max(Math.Min(value, 1f), 0f);
            }
        }

        [NonSerialized]
        private int _top_a = 0;
        public int top_a
        {
            get
            {
                return _top_a;
            }
            set
            {
                _top_a = Math.Max(0, value);
            }
        }

        [NonSerialized]
        private int _top_k = 0;
        public int top_k
        {
            get
            {
                return _top_k;
            }
            set
            {
                _top_k = Math.Max(0, value);
            }
        }

        [NonSerialized]
        private int _top_p = 0;
        public int top_p
        {
            get
            {
                return _top_p;
            }
            set
            {
                _top_p = Math.Max(0, value);
            }
        }

        [NonSerialized]
        private float _typical = 0f;
        public float typical
        {
            get
            {
                return _typical;
            }
            set
            {
                if(value == 0f)
                {
                    _typical = Random.Shared.NextSingle();
                    return;
                }
                _typical = Math.Max(Math.Min(1f, value), 0);
            }
        }

        public bool use_authors_note { get; set; } = false;

        public bool use_default_badwordsids { get; set; } = true;

        public bool use_memory { get; set; } = false;

        public bool use_story { get; set; } = false;

        public bool use_userscripts { get; set; } = false;

        public bool use_world_info { get; set; } = false;
    }

    public class GenerationResult
    {
        public string text { get; set; } = string.Empty;
    }

    public class GenerationOutput
    {
        public GenerationResult[] results { get; set; } = Array.Empty<GenerationResult>();
    }

    public class GensPerActionSetting
    {
        [NonSerialized]
        private int _value = 0;

        public int value
        {
            get
            {
                return _value;
            }
            set
            {
                if(value < 0)
                {
                    _value = 0;
                    return;
                }
                if(value > 5) 
                {
                    _value = 5;
                    return;
                }
                _value = value;
            }
        }
    }

    public class MaxContextLengthSetting
    {
        [NonSerialized]
        private int _value = 0;
        public int value
        {
            get
            {
                return _value;
            }
            set
            {
                if(value < 512) 
                {
                    _value = 512;
                    return;
                }
                if(value > 2048)
                {
                    _value = 2048;
                    return;
                }
                _value = value;
            }
        }
    }

    public class MaxLengthSetting
    {
        [NonSerialized]
        private int _value = 0;
        public int value
        {
            get
            {
                return _value;
            }
            set
            {
                if(value > 512)
                {
                    _value = 512;
                    return;
                }
                if(value < 1)
                {
                    _value = 1;
                    return;
                }
                _value = value;
            }
        }
    }
}
