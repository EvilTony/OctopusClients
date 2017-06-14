namespace Octopus.DataCenterManager.Client
{

    public interface IOctopusDataCenterManagerRepository
    {

    }

    public class OctopusDataCenterManagerRepository : IOctopusDataCenterManagerRepository
    {
        private IOctopusDataCenterManagerClient client;

        public OctopusDataCenterManagerRepository(IOctopusDataCenterManagerClient client)
        {
            this.client = client;
        }
    }
}