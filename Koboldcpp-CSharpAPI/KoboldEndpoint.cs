
namespace Koboldcpp_CSharpAPI
{
    public class KoboldEndpoint
    {
        public const string DefaultEndpointURL = "http://127.0.0.1:5001";

        private string _endpoint = "http://127.0.0.1:5001";

        public string EndpointURL
        {
            get
            {
                if(_endpoint == null)
                {
                    Logger.LogError("Endpoint url was null!");
                    _endpoint = DefaultEndpointURL;
                }
                return _endpoint;
            }
        }

        public KoboldEndpoint()
        {
            _endpoint = DefaultEndpointURL;
        }

        public KoboldEndpoint(string url) 
        {
            _endpoint = url;
        }
    }
}
