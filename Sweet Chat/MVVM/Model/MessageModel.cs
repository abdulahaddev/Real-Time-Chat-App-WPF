using System;
using System.Collections.Generic;
using System.Text;

namespace Sweet_Chat.MVVM.Model
{
    class MessageModel
    {
        public string MemberName { get; set; }
        public string MemberNameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool? FirstMessage { get; set; }
    }
}
