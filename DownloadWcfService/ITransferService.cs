using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DownloadWcfService
{
    [ServiceContract]
    public interface ITransferService
    {
        [OperationContract]
        RemoteFileInfo DownloadFile(DownloadRequest request);

        [OperationContract]
        void UploadFile(RemoteFileInfo request);
    }
    [DataContract]
    public class DownloadRequest
    {
        [DataMember]
        public string FileName;
    }

    [DataContract]
    public class RemoteFileInfo : IDisposable
    {
        [DataMember]
        public string FileName;

        [DataMember]
        public long Length;

        [DataMember]
        public byte[] FileByteStream;

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream = null;
            }
        }
    }
}
