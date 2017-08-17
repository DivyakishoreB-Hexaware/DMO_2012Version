﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_BusinessEntities
{
    public class HXROfflineStatusEntity
    {
        public long Offline_Job_ID { get; set; }

        public string Client_ID { get; set; }

        public string Project_ID { get; set; }

        public string Tool_Name { get; set; }

        public Nullable<long> Config_ID { get; set; }

        public string Template_Name { get; set; }

        public string Table_Name { get; set; }

        public string Column_Name { get; set; }

        public string Run_Status { get; set; }

        public string Task_Description { get; set; }

        public string Template_Path { get; set; }

        public string Procedure_Name { get; set; }

        public string Parameter_List { get; set; }

        public Nullable<System.DateTime> Start_Time { get; set; }

        public Nullable<System.DateTime> End_Time { get; set; }

        public string Created_by { get; set; }

        public Nullable<int> Tool_ID { get; set; }

        public string Run_Status_Message { get; set; }

        public Nullable<long> Ref_Run_ID { get; set; }
    }
}