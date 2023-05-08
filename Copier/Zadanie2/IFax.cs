
using ver1;

namespace Zadanie2
{
    public interface IFax
    {
        /// <summary>
        /// Dokument jest wysyłany faxem, jeśli urządzenie włączone. W przeciwnym przypadku nic się nie wykonuje
        /// </summary>
        /// <param name="document">obiekt typu IDocument, różny od `null`</param>
        void Fax(in IDocument document);
    }

}
