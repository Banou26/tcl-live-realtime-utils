using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AntilopeGP.Shared.Geolocation
{
	public class GeolocationManager
	{
		public async Task<Location> GetUserLocation()
		{
			_ = 2;
			try
			{
				PermissionStatus status = PermissionStatus.Unknown;
				await Device.InvokeOnMainThreadAsync(async delegate
				{
					status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
					if (status != PermissionStatus.Granted)
					{
						status = (await CrossPermissions.Current.RequestPermissionsAsync(Permission.LocationWhenInUse))[Permission.LocationWhenInUse];
					}
				});
				if (status != PermissionStatus.Granted)
				{
					return null;
				}
				GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromSeconds(10.0));
				Location location = await Xamarin.Essentials.Geolocation.GetLocationAsync(request);
				if (location != null)
				{
					return location;
				}
				return await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
