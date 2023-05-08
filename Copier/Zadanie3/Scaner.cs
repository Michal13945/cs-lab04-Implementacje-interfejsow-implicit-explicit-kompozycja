
using ver1;

namespace Zadanie3
{
    public class Scaner : IScanner
    {
        public int Counter => throw new NotImplementedException();

        public IDevice.State GetState()
        {
            throw new NotImplementedException();
        }

        public void PowerOff()
        {
            throw new NotImplementedException();
        }

        public void PowerOn()
        {
            throw new NotImplementedException();
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            throw new NotImplementedException();
        }
    }
}
