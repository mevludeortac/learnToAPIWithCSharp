using System;
namespace GetNSetsDetails
{
    public class Customer
    {
        private string _firstName;
        public int Id { get; set; }
        //implementasyon detayının gizlenmesi: encapsulation
        //property'e herhangi bir özellik eklemek istediğimizde get ve set içine yazabiliriz
        public string Name {
            get
                {
                return "Mrs. " + _firstName;
                }
            set
                {
                _firstName = value;
                }
        }
    }
}
