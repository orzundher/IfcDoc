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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcProfilePropertyResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralLoadResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("3dad840c-ea0d-49bf-a545-52ea60ed4fc7")]
	public partial class IfcStructuralResultGroup : IfcGroup
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcAnalysisTheoryTypeEnum _TheoryType;
	
		[DataMember(Order=1)] 
		IfcStructuralLoadGroup _ResultForLoadGroup;
	
		[DataMember(Order=2)] 
		[Required()]
		Boolean _IsLinear;
	
		[InverseProperty("HasResults")] 
		ISet<IfcStructuralAnalysisModel> _ResultGroupFor = new HashSet<IfcStructuralAnalysisModel>();
	
	
		[Description("Specifies the analysis theory used to obtain the respective results.")]
		public IfcAnalysisTheoryTypeEnum TheoryType { get { return this._TheoryType; } set { this._TheoryType = value;} }
	
		[Description("Reference to an instance of IfcStructuralLoadGroup for which this instance repres" +
	    "ents the result.")]
		public IfcStructuralLoadGroup ResultForLoadGroup { get { return this._ResultForLoadGroup; } set { this._ResultForLoadGroup = value;} }
	
		[Description("This Boolean value allows to easily recognize if a linear analysis has been appli" +
	    "ed (allowing the superposition of analysis results), or vice versa.")]
		public Boolean IsLinear { get { return this._IsLinear; } set { this._IsLinear = value;} }
	
		[Description("Reference to an instance of IfcStructuralAnalysisModel for which this instance ca" +
	    "ptures a result.")]
		public ISet<IfcStructuralAnalysisModel> ResultGroupFor { get { return this._ResultGroupFor; } }
	
	
	}
	
}
