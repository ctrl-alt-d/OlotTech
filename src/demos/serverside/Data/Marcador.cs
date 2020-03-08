using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace serverside.Data
{
    public class Marcador: INotifyPropertyChanged
    {
        public 
        int _local = 0;
        int _visitant = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")  
        {  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }  
        public int Local => _local;
        public int Visitant => _visitant;
        
        public void IncrementaLocal() 
        {
            _local++;
            this.NotifyPropertyChanged();
        }
        public void DecrementaLocal()
        {
            _local--;
            if (_local<0) _local = 0;
            this.NotifyPropertyChanged();
        }

        public void IncrementaVisitant() 
        {
            _visitant++;
            this.NotifyPropertyChanged();
        }
        public void DecrementaVisitant()
        {
            _visitant--;
            if (_visitant<0) _visitant = 0;
            this.NotifyPropertyChanged();
        }

    }

}