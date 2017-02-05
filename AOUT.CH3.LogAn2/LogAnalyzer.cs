namespace AOUT.CH3.LogAn2
{
    public interface IExtensionManager
    {
        bool IsValid(string fileName);
    }

    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
            // здесь читается файл                   
        }
    }

    public class AlwaysValidFakeExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }

    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }        

        public bool IsValidLogFileName(string fileName)
        {           
            return manager.IsValid(fileName);
        }       
    }    
}
