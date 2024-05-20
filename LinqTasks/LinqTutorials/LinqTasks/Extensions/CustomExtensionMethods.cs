using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        return emps.Where(emp => emps.Any(e => e.Mgr != null && e.Mgr.Empno == emp.Empno))
            .OrderBy(emp => emp.Ename)
            .ThenByDescending(emp => emp.Salary);
    }
}