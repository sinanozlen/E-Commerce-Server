using Microsoft.AspNetCore.Components.Forms;

namespace E_Commerce_Server.Service.IService
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile filePath);

        bool DeleteFile(string filePath);
    }
}
