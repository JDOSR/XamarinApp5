using System;
namespace XamarinApp4
{
	public class MainPageViewModel
	{

		private string _firstName;
		public string FirstName {
			get => _firstName;
			set {
				_firstName = value;
			}
		}
		public MainPageViewModel()
		{

			FirstName = "Jason";
		}
	}
}
