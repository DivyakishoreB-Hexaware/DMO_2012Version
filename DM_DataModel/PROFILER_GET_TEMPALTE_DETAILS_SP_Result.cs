
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DM_DataModel
{

using System;
    
public partial class PROFILER_GET_TEMPALTE_DETAILS_SP_Result
{

    public string Template_Name { get; set; }

    public string Table_Name { get; set; }

    public string Column_Name { get; set; }

    public bool Null_Ratio_Profile { get; set; }

    public bool Statistics_Profile { get; set; }

    public bool Value_Distribution_Profile { get; set; }

    public bool Length_Distribution_Profile { get; set; }

    public bool Pattern_Profile { get; set; }

    public bool Candidate_Key_Profile { get; set; }

    public bool Profiling_Status { get; set; }

    public string Profile_Type { get; set; }

    public Nullable<long> Rec_Count { get; set; }

}

}
