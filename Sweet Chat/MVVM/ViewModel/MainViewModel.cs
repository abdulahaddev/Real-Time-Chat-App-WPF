using Sweet_Chat.Core;
using Sweet_Chat.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Sweet_Chat.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages{ get; set; }
        public ObservableCollection<MemberModel> Members { get; set; }

        /*Command*/
        public RelayCommand SendCommand { get; set; }

        private MemberModel _selectedMember;

        public MemberModel SelectedMember
        {
            get { return _selectedMember; }
            set 
            { 
                _selectedMember = value;
                OnPropertyChanged();
            }
        }


        private string _message;

        public string Message
        {
            get { return _message; }
            set 
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Members = new ObservableCollection<MemberModel>();

            SendCommand = new RelayCommand(o => 
            {
                Messages.Add(new MessageModel 
                {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";
            });

            Messages.Add(new MessageModel() { 
                MemberName = "Ahad",
                MemberNameColor = "red",
                ImageSource = "https://cdn-icons-png.flaticon.com/256/4825/4825087.png",
                Message = "This is my message",
                IsNativeOrigin = false,
                FirstMessage = true
            
            });
            for (int i = 0; i < 5; i++)
            {
                Members.Add(new MemberModel()
                {
                    MemberName = $"User{i}",
                    Messages = Messages,
                    ImageSource = "https://cdn-icons-png.flaticon.com/256/4825/4825087.png"
                });
            }
        }
    }
}
