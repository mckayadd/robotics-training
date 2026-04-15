using RoboticsTraining;
using RoboticsTraining.WPF.Commands;
using System.Windows.Input;

namespace RoboticsTraining.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public Robot Robot { get; set; }

        private string _robotName;

        public string RobotName
        {
            get => _robotName; 
            set 
            { 
                _robotName = value; 
                OnPropertyChanged();
            }
        }

        private Position _robotPosition;

        public Position RobotPosition
        {
            get => _robotPosition;
            set 
            { 
                _robotPosition = value; 
                OnPropertyChanged();
            }
        }

        public ICommand MoveRobotCommand { get;  }

        public MainViewModel(String  robotName,  Position robotPosition) 
        {
            _robotName = robotName;
            _robotPosition = robotPosition;
            Robot = new Robot(_robotName, _robotPosition);
            MoveRobotCommand = new RelayCommand(
                    () => MoveRobot(new Position(4.0, 5.0, 6.0))
                );
        }

        public void MoveRobot(Position newPosition)
        { 
            Robot.MoveTo(newPosition);
            RobotName = Robot.Name;
            RobotPosition = Robot.CurrentPosition;
        }

    }
}
