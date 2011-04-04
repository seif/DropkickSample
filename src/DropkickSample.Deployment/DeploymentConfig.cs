namespace DropkickSample.Deployment
{
    using dropkick.Configuration;

    public class DeploymentConfig : DropkickConfiguration
    {
        public string DeployPath { get; set; }
    }
}