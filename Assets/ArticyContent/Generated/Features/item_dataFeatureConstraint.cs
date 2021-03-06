//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Project_Of_Death;
using Articy.Unity;
using Articy.Unity.Constraints;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Project_Of_Death.Features
{
    
    
    public class item_dataFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private TextConstraint mItem_name;
        
        private TextConstraint mItem_description;
        
        private NumberConstraint mItem_price_value;
        
        private EnumConstraint mItem_type_category;
        
        private TextConstraint mItem_flavour_text_first;
        
        private ScriptConstraint mItem_instruction_onbuy;
        
        private TextConstraint mItem_flavour_text_second;
        
        private ReferenceSlotConstraint mItem_icon;
        
        private TextConstraint mItem_flavour_text_third;
        
        private ReferenceSlotConstraint mItem_dialogue;
        
        private ReferenceStripConstraint mItem_variations;
        
        private NumberConstraint mItem_slot_number;
        
        private ScriptConstraint mItem_variable;
        
        public TextConstraint item_name
        {
            get
            {
                EnsureConstraints();
                return mItem_name;
            }
        }
        
        public TextConstraint item_description
        {
            get
            {
                EnsureConstraints();
                return mItem_description;
            }
        }
        
        public NumberConstraint item_price_value
        {
            get
            {
                EnsureConstraints();
                return mItem_price_value;
            }
        }
        
        public EnumConstraint item_type_category
        {
            get
            {
                EnsureConstraints();
                return mItem_type_category;
            }
        }
        
        public TextConstraint item_flavour_text_first
        {
            get
            {
                EnsureConstraints();
                return mItem_flavour_text_first;
            }
        }
        
        public ScriptConstraint item_instruction_onbuy
        {
            get
            {
                EnsureConstraints();
                return mItem_instruction_onbuy;
            }
        }
        
        public TextConstraint item_flavour_text_second
        {
            get
            {
                EnsureConstraints();
                return mItem_flavour_text_second;
            }
        }
        
        public ReferenceSlotConstraint item_icon
        {
            get
            {
                EnsureConstraints();
                return mItem_icon;
            }
        }
        
        public TextConstraint item_flavour_text_third
        {
            get
            {
                EnsureConstraints();
                return mItem_flavour_text_third;
            }
        }
        
        public ReferenceSlotConstraint item_dialogue
        {
            get
            {
                EnsureConstraints();
                return mItem_dialogue;
            }
        }
        
        public ReferenceStripConstraint item_variations
        {
            get
            {
                EnsureConstraints();
                return mItem_variations;
            }
        }
        
        public NumberConstraint item_slot_number
        {
            get
            {
                EnsureConstraints();
                return mItem_slot_number;
            }
        }
        
        public ScriptConstraint item_variable
        {
            get
            {
                EnsureConstraints();
                return mItem_variable;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mItem_name = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, false);
            mItem_description = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, true);
            mItem_price_value = new Articy.Unity.Constraints.NumberConstraint(-3.40282346638529E+38D, 3.40282346638529E+38D, 0, 0, 0, "darksouls");
            mItem_type_category = new Articy.Unity.Constraints.EnumConstraint(false, "BySortIndex");
            mItem_flavour_text_first = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, false);
            mItem_instruction_onbuy = new Articy.Unity.Constraints.ScriptConstraint("Outcome", "");
            mItem_flavour_text_second = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, false);
            mItem_icon = new Articy.Unity.Constraints.ReferenceSlotConstraint("LocationImage;Asset;Entity;", "", "None;Image;Video;Audio;Document;Misc;All;", "");
            mItem_flavour_text_third = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, false);
            mItem_dialogue = new Articy.Unity.Constraints.ReferenceSlotConstraint("Dialogue;", "", "None;", "template_conscience;");
            mItem_variations = new Articy.Unity.Constraints.ReferenceStripConstraint(10000, "Entity;", "", "None;", "template_item_variation;");
            mItem_slot_number = new Articy.Unity.Constraints.NumberConstraint(-1D, 2D, 0, 0, 0, null);
            mItem_variable = new Articy.Unity.Constraints.ScriptConstraint("Condition", "");
        }
    }
}
