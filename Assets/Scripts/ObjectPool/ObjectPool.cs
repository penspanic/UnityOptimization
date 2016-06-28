using UnityEngine;
using System.Collections.Generic;

public class ObjectPool<T> where T : Object
{

    public delegate T CreateMethod(T original);
    public delegate void InitMethod(T target);
    public delegate void ReleaseMethod(T target);


    public CreateMethod createMethod;
    public InitMethod initMethod;
    public ReleaseMethod releaseMethod;
 
    public T original;

    private Stack<T> objects = new Stack<T>();


    private void Create()
    {
        T target = createMethod(original);
        objects.Push(createMethod(original));

    }

    public void Init(int count)
    {
        for (int i = 0; i < count; ++i)
            Create();
    }

    public T Pop()
    {
        if (objects.Count == 0)
            Create();

        T returnObject = objects.Pop();
        initMethod(returnObject);

        return returnObject;
    }

    public void Push(T target)
    {
        releaseMethod(target);
        objects.Push(target);
    }
}
