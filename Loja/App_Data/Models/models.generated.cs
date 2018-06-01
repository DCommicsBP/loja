//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "a096e52342a810af")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.3")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Card Description</summary>
	[PublishedContentModel("cardDescription")]
	public partial class CardDescription : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "cardDescription";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CardDescription(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CardDescription, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Description Title
		///</summary>
		[ImplementPropertyType("descriptionTitle")]
		public string DescriptionTitle
		{
			get { return this.GetPropertyValue<string>("descriptionTitle"); }
		}

		///<summary>
		/// External link Description
		///</summary>
		[ImplementPropertyType("externalLinkDescription")]
		public string ExternalLinkDescription
		{
			get { return this.GetPropertyValue<string>("externalLinkDescription"); }
		}

		///<summary>
		/// Internal Link Description
		///</summary>
		[ImplementPropertyType("internalLinkDescription")]
		public IPublishedContent InternalLinkDescription
		{
			get { return this.GetPropertyValue<IPublishedContent>("internalLinkDescription"); }
		}

		///<summary>
		/// Product Type
		///</summary>
		[ImplementPropertyType("productType")]
		public IEnumerable<string> ProductType
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("productType"); }
		}
	}

	/// <summary>Main Text</summary>
	[PublishedContentModel("mainText")]
	public partial class MainText : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "mainText";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MainText(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MainText, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Text - Main Text
		///</summary>
		[ImplementPropertyType("textMainText")]
		public IHtmlString TextMainText
		{
			get { return this.GetPropertyValue<IHtmlString>("textMainText"); }
		}

		///<summary>
		/// Text Title
		///</summary>
		[ImplementPropertyType("textTitle")]
		public string TextTitle
		{
			get { return this.GetPropertyValue<string>("textTitle"); }
		}
	}

	/// <summary>Images</summary>
	[PublishedContentModel("images")]
	public partial class Images : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "images";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Images(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Images, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description Image
		///</summary>
		[ImplementPropertyType("descriptionImage")]
		public string DescriptionImage
		{
			get { return this.GetPropertyValue<string>("descriptionImage"); }
		}

		///<summary>
		/// External Link Image
		///</summary>
		[ImplementPropertyType("externalLinkImage")]
		public string ExternalLinkImage
		{
			get { return this.GetPropertyValue<string>("externalLinkImage"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}

		///<summary>
		/// Internal Link Image
		///</summary>
		[ImplementPropertyType("internalLinkImage")]
		public IPublishedContent InternalLinkImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("internalLinkImage"); }
		}

		///<summary>
		/// Title Image
		///</summary>
		[ImplementPropertyType("titleImage")]
		public string TitleImage
		{
			get { return this.GetPropertyValue<string>("titleImage"); }
		}
	}

	/// <summary>Links</summary>
	[PublishedContentModel("links")]
	public partial class Links : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "links";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Links(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Links, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Internal Links
		///</summary>
		[ImplementPropertyType("internalLinks")]
		public IPublishedContent InternalLinks
		{
			get { return this.GetPropertyValue<IPublishedContent>("internalLinks"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Header</summary>
	[PublishedContentModel("header")]
	public partial class Header : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "header";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Header(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Header, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IEnumerable<IPublishedContent> Image
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("image"); }
		}

		///<summary>
		/// Links
		///</summary>
		[ImplementPropertyType("links")]
		public IEnumerable<IPublishedContent> Links
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("links"); }
		}
	}

	/// <summary>Footer</summary>
	[PublishedContentModel("footer")]
	public partial class Footer : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "footer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Footer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Footer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// description Footer
		///</summary>
		[ImplementPropertyType("descriptionFooter")]
		public IEnumerable<IPublishedContent> DescriptionFooter
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("descriptionFooter"); }
		}

		///<summary>
		/// Title Footer
		///</summary>
		[ImplementPropertyType("titleFooter")]
		public string TitleFooter
		{
			get { return this.GetPropertyValue<string>("titleFooter"); }
		}
	}

	// Mixin content Type 1220 with alias "descriptions"
	/// <summary>Descriptions</summary>
	public partial interface IDescriptions : IPublishedContent
	{
		/// <summary>Description Things</summary>
		IHtmlString DescriptionThings { get; }

		/// <summary>DTItle</summary>
		string DTitle { get; }
	}

	/// <summary>Descriptions</summary>
	[PublishedContentModel("descriptions")]
	public partial class Descriptions : PublishedContentModel, IDescriptions
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "descriptions";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Descriptions(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Descriptions, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description Things
		///</summary>
		[ImplementPropertyType("descriptionThings")]
		public IHtmlString DescriptionThings
		{
			get { return GetDescriptionThings(this); }
		}

		/// <summary>Static getter for Description Things</summary>
		public static IHtmlString GetDescriptionThings(IDescriptions that) { return that.GetPropertyValue<IHtmlString>("descriptionThings"); }

		///<summary>
		/// DTItle
		///</summary>
		[ImplementPropertyType("dTItle")]
		public string DTitle
		{
			get { return GetDTitle(this); }
		}

		/// <summary>Static getter for DTItle</summary>
		public static string GetDTitle(IDescriptions that) { return that.GetPropertyValue<string>("dTItle"); }
	}

	/// <summary>Contact Us</summary>
	[PublishedContentModel("contactUs")]
	public partial class ContactUs : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Client Email
		///</summary>
		[ImplementPropertyType("clientEmail")]
		public string ClientEmail
		{
			get { return this.GetPropertyValue<string>("clientEmail"); }
		}

		///<summary>
		/// Client Mesage
		///</summary>
		[ImplementPropertyType("clientMesage")]
		public string ClientMesage
		{
			get { return this.GetPropertyValue<string>("clientMesage"); }
		}

		///<summary>
		/// Client Name
		///</summary>
		[ImplementPropertyType("clientName")]
		public string ClientName
		{
			get { return this.GetPropertyValue<string>("clientName"); }
		}
	}

	// Mixin content Type 1235 with alias "abc"
	/// <summary>Alias</summary>
	public partial interface IAbc : IPublishedContent
	{
		/// <summary>Umbraco Url Alias</summary>
		string UmbracoUrlAlias { get; }
	}

	/// <summary>Alias</summary>
	[PublishedContentModel("abc")]
	public partial class Abc : PublishedContentModel, IAbc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "abc";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Abc(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Abc, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return GetUmbracoUrlAlias(this); }
		}

		/// <summary>Static getter for Umbraco Url Alias</summary>
		public static string GetUmbracoUrlAlias(IAbc that) { return that.GetPropertyValue<string>("umbracoUrlAlias"); }
	}

	/// <summary>Master</summary>
	[PublishedContentModel("master")]
	public partial class Master : PublishedContentModel, IAbc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "master";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Master(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Master, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Page Breadcrumb
		///</summary>
		[ImplementPropertyType("pageBreadcrumb")]
		public bool PageBreadcrumb
		{
			get { return this.GetPropertyValue<bool>("pageBreadcrumb"); }
		}

		///<summary>
		/// Page Keywords
		///</summary>
		[ImplementPropertyType("pageKeywords")]
		public IEnumerable<string> PageKeywords
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("pageKeywords"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.Abc.GetUmbracoUrlAlias(this); }
		}
	}

	/// <summary>Content</summary>
	[PublishedContentModel("content")]
	public partial class Content : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "content";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Content(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Content, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IEnumerable<IPublishedContent> Description
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("description"); }
		}

		///<summary>
		/// Text Title
		///</summary>
		[ImplementPropertyType("textTitle")]
		public string TextTitle
		{
			get { return this.GetPropertyValue<string>("textTitle"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : Master, IDescriptions
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("header")]
		public IEnumerable<IPublishedContent> Header
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("header"); }
		}

		///<summary>
		/// Description Things
		///</summary>
		[ImplementPropertyType("descriptionThings")]
		public IHtmlString DescriptionThings
		{
			get { return Umbraco.Web.PublishedContentModels.Descriptions.GetDescriptionThings(this); }
		}

		///<summary>
		/// DTItle
		///</summary>
		[ImplementPropertyType("dTItle")]
		public string DTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Descriptions.GetDTitle(this); }
		}
	}

	/// <summary>Trabalhe Conosco</summary>
	[PublishedContentModel("trabalheConosco")]
	public partial class TrabalheConosco : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "trabalheConosco";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TrabalheConosco(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TrabalheConosco, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Novidades</summary>
	[PublishedContentModel("novidades")]
	public partial class Novidades : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "novidades";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Novidades(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Novidades, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Lojas</summary>
	[PublishedContentModel("lojas")]
	public partial class Lojas : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "lojas";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Lojas(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Lojas, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Products</summary>
	[PublishedContentModel("products")]
	public partial class Products : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "products";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Products(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Products, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Produt Description
		///</summary>
		[ImplementPropertyType("produtDescription")]
		public IEnumerable<IPublishedContent> ProdutDescription
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("produtDescription"); }
		}
	}

	/// <summary>Product Details</summary>
	[PublishedContentModel("productDetails")]
	public partial class ProductDetails : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "productDetails";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProductDetails(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProductDetails, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IEnumerable<IPublishedContent> Image
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("image"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("prodDescription")]
		public string ProdDescription
		{
			get { return this.GetPropertyValue<string>("prodDescription"); }
		}

		///<summary>
		/// Name
		///</summary>
		[ImplementPropertyType("prodName")]
		public string ProdName
		{
			get { return this.GetPropertyValue<string>("prodName"); }
		}

		///<summary>
		/// Value
		///</summary>
		[ImplementPropertyType("prodValue")]
		public string ProdValue
		{
			get { return this.GetPropertyValue<string>("prodValue"); }
		}
	}

	/// <summary>Loja Detatlhe</summary>
	[PublishedContentModel("lojaDetatlhe")]
	public partial class LojaDetatlhe : Lojas
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "lojaDetatlhe";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LojaDetatlhe(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LojaDetatlhe, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
