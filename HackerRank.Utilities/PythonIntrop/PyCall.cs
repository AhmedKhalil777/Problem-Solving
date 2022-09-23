namespace HackerRank.Utilities.PythonIntrop;

public static class PyCall
{
    public static dynamic ExecutePy(this string pyScript, string pyFuncName, params object[] parameters) 
    {
        var eng = IronPython.Hosting.Python.CreateEngine();
        var scope = eng.CreateScope();
        eng.Execute(pyScript, scope);
        dynamic func = scope.GetVariable(pyFuncName); var res  =  func(parameters[0], parameters[1]);
        return res;
    }
}