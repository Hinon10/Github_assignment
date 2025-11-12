namespace Team_assignment.Data;

public class DataContext : IdentityDbContext<User, IdentityRole<int>, int>, IDataContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }


    public async Task MigrateAsync()    
    {
        await Database.MigrateAsync();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(UserConfigurations).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(EmployeeConfigurations).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(DepartmentConfigurations).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(VacationBalanceConfigurations).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(VacationRecordConfigurations).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(SalaryAnomalyConfigurations).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(SalaryHistoryConfigurations).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(PayrollRecordConfigurations).Assembly);
    } 
}