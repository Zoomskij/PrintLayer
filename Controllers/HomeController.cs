using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Auth.AspNetCore3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Microsoft.AspNetCore.Authorization;

namespace PrintLayer.Controllers
{
   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Lists the authenticated user's Google Drive files.
        /// Specifying the <see cref="GoogleScopedAuthorizeAttribute"> will guarantee that the code
        /// executes only if the user is authenticated and has granted the scope specified in the attribute
        /// to this application.
        /// </summary>
        /// <param name="auth">The Google authorization provider.
        /// This can also be injected on the controller constructor.</param>
        [GoogleScopedAuthorize(DriveService.ScopeConstants.DriveReadonly)]
        public async Task<IActionResult> DriveFileList([FromServices] IGoogleAuthProvider auth)
        {
            GoogleCredential cred = await auth.GetCredentialAsync();
            var service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = cred
            });
            var files = await service.Files.List().ExecuteAsync();
            var fileNames = files.Files.Select(x => x.Name).ToList();
            return BadRequest();
            //return View(fileNames);
        }
    }
}
