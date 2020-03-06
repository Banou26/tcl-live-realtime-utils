using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AntilopeGP.Shared.ViewModels.Favoris
{
	public class InfoLigne : INotifyPropertyChanged
	{
		public string ModeImagePath
		{
			[CompilerGenerated]
			get
			{
				return _003CModeImagePath_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CModeImagePath_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CModeImagePath_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.ModeImagePath);
				}
			}
		}

		public string LigneImagePath
		{
			[CompilerGenerated]
			get
			{
				return _003CLigneImagePath_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CLigneImagePath_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CLigneImagePath_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.LigneImagePath);
				}
			}
		}

		public string Ligne
		{
			[CompilerGenerated]
			get
			{
				return _003CLigne_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CLigne_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CLigne_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Ligne);
				}
			}
		}

		public string Sens
		{
			[CompilerGenerated]
			get
			{
				return _003CSens_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CSens_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CSens_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Sens);
				}
			}
		}

		public string Destination
		{
			[CompilerGenerated]
			get
			{
				return _003CDestination_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CDestination_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CDestination_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Destination);
				}
			}
		}

		[field: NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		[GeneratedCode("PropertyChanged.Fody", "3.2.1.0")]
		[DebuggerNonUserCode]
		protected void _003C_003EOnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			this.PropertyChanged?.Invoke(this, eventArgs);
		}
	}
}
