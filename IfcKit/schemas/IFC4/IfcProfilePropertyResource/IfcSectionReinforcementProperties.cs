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

using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProfileResource;

namespace BuildingSmart.IFC.IfcProfilePropertyResource
{
	[Guid("b63f39d4-5418-4d17-8498-691e25346675")]
	public partial class IfcSectionReinforcementProperties
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcLengthMeasure _LongitudinalStartPosition;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcLengthMeasure _LongitudinalEndPosition;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcLengthMeasure? _TransversePosition;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		[Required()]
		IfcReinforcingBarRoleEnum _ReinforcementRole;
	
		[DataMember(Order=4)] 
		[Required()]
		IfcSectionProperties _SectionDefinition;
	
		[DataMember(Order=5)] 
		[Required()]
		ISet<IfcReinforcementBarProperties> _CrossSectionReinforcementDefinitions = new HashSet<IfcReinforcementBarProperties>();
	
	
		[Description("The start position in longitudinal direction for the section reinforcement proper" +
	    "ties.\r\n")]
		public IfcLengthMeasure LongitudinalStartPosition { get { return this._LongitudinalStartPosition; } set { this._LongitudinalStartPosition = value;} }
	
		[Description("The end position in longitudinal direction for the section reinforcement properti" +
	    "es.")]
		public IfcLengthMeasure LongitudinalEndPosition { get { return this._LongitudinalEndPosition; } set { this._LongitudinalEndPosition = value;} }
	
		[Description("The position for the section reinforcement properties in transverse direction.")]
		public IfcLengthMeasure? TransversePosition { get { return this._TransversePosition; } set { this._TransversePosition = value;} }
	
		[Description("The role, purpose or usage of the reinforcement, i.e. the kind of loads and stres" +
	    "ses it is intended to carry, defined for the section reinforcement properties.")]
		public IfcReinforcingBarRoleEnum ReinforcementRole { get { return this._ReinforcementRole; } set { this._ReinforcementRole = value;} }
	
		[Description("Definition of the cross section profile and longitudinal section type.")]
		public IfcSectionProperties SectionDefinition { get { return this._SectionDefinition; } set { this._SectionDefinition = value;} }
	
		[Description("The set of reinforcment properties attached to a section reinforcement\r\npropertie" +
	    "s definition.")]
		public ISet<IfcReinforcementBarProperties> CrossSectionReinforcementDefinitions { get { return this._CrossSectionReinforcementDefinitions; } }
	
	
	}
	
}
