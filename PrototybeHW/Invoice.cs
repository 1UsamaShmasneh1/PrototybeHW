namespace Prototype
{
    [Serializable]
    class Invoice : Proto<Invoice>
    {
        public Custumer Custumer { get; set; }
        public double TotalToPay { get; set; }

        public Invoice Clone()
        {
            return new Invoice(this.Custumer.Clone(), this.TotalToPay);
        }

        public Invoice(Custumer custumer, double totalToPay)
        {
            Custumer = custumer.Clone();
            TotalToPay = totalToPay;
        }
    }


}