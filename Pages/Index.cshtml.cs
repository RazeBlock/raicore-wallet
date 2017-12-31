namespace RaicoreWallet.Pages {
	using ElectronNET.API;
	using Microsoft.AspNetCore.Mvc.RazorPages;

	public class IndexModel : PageModel {
		public string ApplicationPath { get; set; }

		public async void OnGetAsync() {
			ApplicationPath = await Electron.App.GetAppPathAsync();
		}
	}
}