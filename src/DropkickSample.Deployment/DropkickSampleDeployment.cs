namespace DropkickSample.Deployment
{
    using dropkick.Configuration.Dsl;
    using dropkick.Configuration.Dsl.Files;

    public class DropkickSampleDeployment : Deployment<DropkickSampleDeployment, DeploymentConfig>
    {
        public static Role ConsoleApp;

        public DropkickSampleDeployment()
        {
            Define((settings) => DeploymentStepsFor( ConsoleApp, server =>
            { 
                server.CopyDirectory(@"..\..\..\DropkickSample.ConsoleApp\bin\debug")
                    .To(settings.DeployPath)
                    .DeleteDestinationBeforeDeploying();
            }));
        }
    }
}