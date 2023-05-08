
using ver1;

namespace Zadanie3
{
    public class Printer : IPrinter
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

        public void Print(in IDocument document)
        {
            throw new NotImplementedException();
        }
    }
}
