// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;

namespace BuildingSmart.IFC.IfcTopologyResource
{
	[Guid("606bfe59-169d-4543-89a1-60d81d609835")]
	public partial class IfcPolyLoop : IfcLoop
	{
		[DataMember(Order=0)] 
		[Required()]
		IList<IfcCartesianPoint> _Polygon = new List<IfcCartesianPoint>();
	
	
		[Description("List of points defining the loop. There are no repeated points in the list. ")]
		public IList<IfcCartesianPoint> Polygon { get { return this._Polygon; } }
	
	
	}
	
}
