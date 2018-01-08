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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcRepresentationResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("c7355be1-dea2-45e4-a9eb-2d5e95b82f5f")]
	public enum IfcWindowTypeEnum
	{
		[Description("A standard window usually within a wall opening, as a window panel in a curtain w" +
	    "all, or as a \"free standing\" window.")]
		WINDOW = 1,
	
		[Description("A window within a sloped building element, usually a roof slab.")]
		SKYLIGHT = 2,
	
		[Description("A special window that lies horizonally in a roof slab opening.")]
		LIGHTDOME = 3,
	
		[Description("User-defined window element.")]
		USERDEFINED = -1,
	
		[Description("Undefined window element.")]
		NOTDEFINED = 0,
	
	}
}
