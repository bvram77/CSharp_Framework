namespace com.venkat.framework.core
{
    public class FrameworkParameters
    {
        private string relativePath;
        private string runConfiguration;
        private bool stopExecution = false;
        private static readonly FrameworkParameters frameworkParameters = new FrameworkParameters();

        public virtual string RelativePath
        {
            get
            {
                return this.relativePath;
            }
            set
            {
                this.relativePath = value;
            }
        }

        public virtual string RunConfiguration
        {
            get
            {
                return this.runConfiguration;
            }
            set
            {
                this.runConfiguration = value;
            }
        }

        public virtual bool StopExecution
        {
            get
            {
                return this.stopExecution;
            }
            set
            {
                this.stopExecution = value;
            }
        }

        public static FrameworkParameters Instance
        {
            get
            {
                return frameworkParameters;
            }
        }

    }

}
