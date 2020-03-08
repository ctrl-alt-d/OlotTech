namespace serverside.Data
{
    public class Marcador
    {
        int _local = 0;
        int _visitant = 0;
        public int Local => _local;
        public int Visitant => _visitant;
        
        public void IncrementaLocal() 
        {
            _local++;
        }
        public void DecrementaLocal()
        {
            _local--;
            if (_local<0) _local = 0;
        }

        public void IncrementaVisitant() 
        {
            _visitant++;
        }
        public void DecrementaVisitant()
        {
            _visitant--;
            if (_visitant<0) _visitant = 0;
        }

    }

}