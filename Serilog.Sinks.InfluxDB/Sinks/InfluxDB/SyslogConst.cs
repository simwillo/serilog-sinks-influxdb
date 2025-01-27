﻿namespace Serilog.Sinks.InfluxDB
{
    internal static class SyslogConst
    {
        internal static readonly string PointName = "syslog";

        internal static class Tags
        {
            internal static readonly string Level = "level";
            internal static readonly string AppName = "appname";
            internal static readonly string Facility = "facility";
            internal static readonly string Hostname = "hostname";
            internal static readonly string Severity = "severity";
            internal static readonly string ExceptionType = "exceptionType";
        }

        internal static class Fields
        {
            internal static readonly string Message = "message";
            internal static readonly string Facility = "facility_code";
            internal static readonly string ProcId = "procid";
            internal static readonly string Severity = "severity_code";
            internal static readonly string Timestamp = "timestamp";
            internal static readonly string Version = "version";
            internal static readonly string Exception = "exception";

            internal static class Values
            {
                internal static readonly int Facility = 16;
                internal static readonly int Version = 1;
            }            
        }
    }
}
