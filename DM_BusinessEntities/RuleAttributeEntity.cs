﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_BusinessEntities
{
    public class RuleAttributeEntity
    {
        public long Attribute_Rule_ID { get; set; }
        public string Client_ID { get; set; }
        public string Project_ID { get; set; }
        public Nullable<long> Rule_ID { get; set; }
        public string Rule_Name { get; set; }
        public string Rule_Description { get; set; }
        public Nullable<long> RuleType_ID { get; set; }
        public string RuleType_Name { get; set; }
        public string RuleType_Desc { get; set; }
        public Nullable<long> RuleCategory_ID { get; set; } 
        public string RuleCategory_Name { get; set; }
        public string RuleCategory_Desc { get; set; }
        public string Error_Code { get; set; }
        public string Error_Description { get; set; }
        public long status { get; set; }
        public string Table_Name { get; set; }
        public string Column_Name { get; set; }
        public string Default_Value { get; set; }
        public string Conditional_Clause { get; set; }
        public string Priority { get; set; }
        public string Reference_Table { get; set; }
        public string Reference_Column { get; set; }
        public string Reference_Cond { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<long> Version_No { get; set; }
        public System.DateTime Create_Date { get; set; }
        public Nullable<System.DateTime> Last_Modified_Date { get; set; }
        public string Last_Modified_By { get; set; }
        public string Rule_Desc { get; set; }
        public string Data_Steward { get; set; } 

    }
}