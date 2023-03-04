namespace LeetCode.Algorithms;

public class H2O
{
    private static object syncRoot = new();
    private long hydrogens;
    private long oxygens;

    private static bool decrement = false;
    public H2O()
    {
    }

    public void Hydrogen(Action releaseHydrogen)
    {
        while (Interlocked.Read(ref hydrogens) >= 2 || decrement) 
            Thread.Yield();


        Interlocked.Increment(ref hydrogens);


        // releaseHydrogen() outputs "H". Do not change or remove this line.
        releaseHydrogen();
    }

    public void Oxygen(Action releaseOxygen)
    {
        while (Interlocked.Read(ref hydrogens) < 2 || decrement)
            Thread.Yield();

        
        Interlocked.Increment(ref oxygens);


        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();

        // Decrement H20
        lock (syncRoot)
        {
            decrement = true;
            Interlocked.Decrement(ref oxygens);
            Interlocked.Decrement(ref hydrogens);
            Interlocked.Decrement(ref hydrogens);
            decrement = false;
        } 
        

    }
}


public class H2OCreator {
    private readonly Semaphore H_to_O = new(0, 2);
    private readonly Semaphore O_to_H = new (2, 2);

    private readonly object syncLock = new ();
    private readonly object semLock = new ();

    public H2OCreator() {
    }

    public void Hydrogen(Action releaseHydrogen) {
        
        O_to_H.WaitOne();

        lock (syncLock) {
            // releaseHydrogen() outputs "H". Do not change or remove this line.
            releaseHydrogen();
        }

        H_to_O.Release();
    }

    public void Oxygen(Action releaseOxygen) {
        lock (semLock) {
            H_to_O.WaitOne();
            H_to_O.WaitOne();
        }

        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();

        O_to_H.Release(2);
    }
}