namespace RaicoreWallet {
	using ElectronNET.API;
	using ElectronNET.API.Entities;
	using Microsoft.AspNetCore.Builder;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.Extensions.DependencyInjection;

	public class Startup {
		public void ConfigureServices(IServiceCollection services) {
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();

			if (HybridSupport.IsElectronActive) {
				BootstrapElectron();
			}
		}

		private static async void BootstrapElectron() {
			var options = new BrowserWindowOptions {
				WebPreferences = new WebPreferences {
					WebSecurity = true
				},

				// Visual Changes
				Frame = false,
				BackgroundColor = "#444",
				Show = false,
				Center = true
			};

			BrowserWindow window = await Electron.WindowManager.CreateWindowAsync(options);

			window.SetTitle("raicore wallet");
			window.OnReadyToShow += delegate {
				window.Show();

#if DEBUG
				window.WebContents.OpenDevTools();
#endif
			};
		}
	}
}