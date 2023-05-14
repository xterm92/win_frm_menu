public class APMCommonMemory
{
        public static APMCommonMemory apmCommonMemory;

        public string x1 = string.Empty;
        public string ____x1
        {
            get { return x1; }
            set { x1 = value; }
        }
	public string Height = string.Empty;
        public string ____Height
        {
            get { return Height; }
            set { Height = value; }
        }
	public string Width = string.Empty;
        public string ____Width
        {
            get { return Width; }
            set { Width = value; }
        }

        public APMCommonMemory() { }
        public static APMCommonMemory GetInstance
        {
            get
            {
                if (apmCommonMemory == null)
                    apmCommonMemory = new APMCommonMemory();
                return apmCommonMemory;
            }
        }
}


