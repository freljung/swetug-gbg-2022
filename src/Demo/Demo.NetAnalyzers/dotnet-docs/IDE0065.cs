using System.Text;

namespace ca2213
{
    public class UsingShouldBeInsdeNamespace
    {
        public string AssembleString()
        {
            var assembledString = new StringBuilder();
            assembledString.AppendLine("This requires namespace System.Text.");
            return assembledString.ToString();
        }
    }
}
