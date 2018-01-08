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

using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("da40a055-7f34-44ae-85cb-40b20d82ae5a")]
	public abstract partial class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem
	{
		[DataMember(Order=0)] 
		[XmlElement("IfcDirection")]
		IfcDirection _Axis1;
	
		[DataMember(Order=1)] 
		[XmlElement("IfcDirection")]
		IfcDirection _Axis2;
	
		[DataMember(Order=2)] 
		[XmlElement("IfcCartesianPoint")]
		[Required()]
		IfcCartesianPoint _LocalOrigin;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcReal? _Scale;
	
	
		[Description("The direction used to determine U[1], the derived X axis direction.")]
		public IfcDirection Axis1 { get { return this._Axis1; } set { this._Axis1 = value;} }
	
		[Description("The direction used to determine U[2], the derived Y axis direction.")]
		public IfcDirection Axis2 { get { return this._Axis2; } set { this._Axis2 = value;} }
	
		[Description("The required translation, specified as a cartesian point. The actual translation " +
	    "included in the transformation is from the geometric origin to the local origin." +
	    "")]
		public IfcCartesianPoint LocalOrigin { get { return this._LocalOrigin; } set { this._LocalOrigin = value;} }
	
		[Description("The scaling value specified for the transformation.")]
		public IfcReal? Scale { get { return this._Scale; } set { this._Scale = value;} }
	
	
	}
	
}
