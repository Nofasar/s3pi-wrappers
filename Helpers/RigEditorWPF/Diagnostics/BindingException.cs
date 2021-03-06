﻿using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace s3piwrappers.RigEditor.Diagnostics
{
    [Serializable]
    public sealed class BindingException : Exception
    {
        internal BindingException(string message, BindingExceptionInformation information)
            : base(message)
        {
            Information = information;
        }

        private BindingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        public BindingExceptionInformation Information { get; private set; }
    }
}
