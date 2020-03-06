using Keolis.AntilopeGrandPublic.FrontendCommon.Model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace AntilopeGP.Shared.ViewModels.Favoris
{
	public class Favori : INotifyPropertyChanged
	{
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CName_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CName_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavoriPreferences);
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Name);
				}
			}
		}

		public Extent MapExtent
		{
			[CompilerGenerated]
			get
			{
				return _003CMapExtent_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(_003CMapExtent_003Ek__BackingField, value))
				{
					_003CMapExtent_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavoriPreferences);
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.MapExtent);
				}
			}
		}

		public IList<InfoLigne> Lignes
		{
			[CompilerGenerated]
			get
			{
				return _003CLignes_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(_003CLignes_003Ek__BackingField, value))
				{
					_003CLignes_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavoriPreferences);
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Lignes);
				}
			}
		}

		public bool AlternateRow
		{
			[CompilerGenerated]
			get
			{
				return _003CAlternateRow_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CAlternateRow_003Ek__BackingField != value)
				{
					_003CAlternateRow_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.BackgroundColor);
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.AlternateRow);
				}
			}
		}

		public Color BackgroundColor
		{
			get
			{
				if (!AlternateRow)
				{
					return Color.FromHex("#F8F5F7");
				}
				return Color.FromHex("#ECE8EA");
			}
		}

		public FavoriPreferences FavoriPreferences => new FavoriPreferences
		{
			Name = Name,
			MapExtent = MapExtent,
			Lignes = Lignes.Select((InfoLigne x) => new LigneSens
			{
				Ligne = x.Ligne,
				Sens = x.Sens,
				Destination = x.Destination
			})
		};

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
