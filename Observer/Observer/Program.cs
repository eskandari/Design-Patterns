using Observer.IObserver;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            StockTicker st = new StockTicker();

            GoogleMonitor gf = new GoogleMonitor();
            MicrosoftMonitor mf = new MicrosoftMonitor();

            using (st.Subscribe(gf))
            using (st.Subscribe(mf))
            {
                foreach (var s in SampleData.getNext())
                    st.Stock = s;
            }
        }
    }
}
