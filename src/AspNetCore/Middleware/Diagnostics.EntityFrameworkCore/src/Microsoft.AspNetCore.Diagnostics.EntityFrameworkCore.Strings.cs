// <auto-generated>
using System.Reflection;


namespace Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
{
    internal static partial class Strings
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Strings)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>The context type '{0}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped&lt;&gt;() inside the UseServices(...) call in your application startup code. Skipping display of t ...</summary>
        internal static string DatabaseErrorPageMiddleware_ContextNotRegistered => GetResourceString("DatabaseErrorPageMiddleware_ContextNotRegistered");
        /// <summary>The context type '{0}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped&lt;&gt;() inside the UseServices(...) call in your application startup code. Skipping display of t ...</summary>
        internal static string FormatDatabaseErrorPageMiddleware_ContextNotRegistered(object p0)
           => string.Format(Culture, GetResourceString("DatabaseErrorPageMiddleware_ContextNotRegistered"), p0);

        /// <summary>An exception occurred while calculating the database error page content. Skipping display of the database error page.</summary>
        internal static string DatabaseErrorPageMiddleware_Exception => GetResourceString("DatabaseErrorPageMiddleware_Exception");
        /// <summary>&gt; dotnet ef migrations add [migration name]</summary>
        internal static string DatabaseErrorPage_AddMigrationCommandCLI => GetResourceString("DatabaseErrorPage_AddMigrationCommandCLI");
        /// <summary>Apply Migrations</summary>
        internal static string DatabaseErrorPage_ApplyMigrationsButton => GetResourceString("DatabaseErrorPage_ApplyMigrationsButton");
        /// <summary>Migrations Applied</summary>
        internal static string DatabaseErrorPage_ApplyMigrationsButtonDone => GetResourceString("DatabaseErrorPage_ApplyMigrationsButtonDone");
        /// <summary>Applying Migrations...</summary>
        internal static string DatabaseErrorPage_ApplyMigrationsButtonRunning => GetResourceString("DatabaseErrorPage_ApplyMigrationsButtonRunning");
        /// <summary>An error occurred applying migrations, try applying them from the command line</summary>
        internal static string DatabaseErrorPage_ApplyMigrationsFailed => GetResourceString("DatabaseErrorPage_ApplyMigrationsFailed");
        /// <summary>In Visual Studio, you can use the Package Manager Console to apply pending migrations to the database:</summary>
        internal static string DatabaseErrorPage_HowToApplyFromPMC => GetResourceString("DatabaseErrorPage_HowToApplyFromPMC");
        /// <summary>Try refreshing the page</summary>
        internal static string DatabaseErrorPage_MigrationsAppliedRefresh => GetResourceString("DatabaseErrorPage_MigrationsAppliedRefresh");
        /// <summary>In Visual Studio, use the Package Manager Console to scaffold a new migration and apply it to the database:</summary>
        internal static string DatabaseErrorPage_NoDbOrMigrationsInfoPMC => GetResourceString("DatabaseErrorPage_NoDbOrMigrationsInfoPMC");
        /// <summary>Use migrations to create the database for {0}</summary>
        internal static string DatabaseErrorPage_NoDbOrMigrationsTitle => GetResourceString("DatabaseErrorPage_NoDbOrMigrationsTitle");
        /// <summary>Use migrations to create the database for {0}</summary>
        internal static string FormatDatabaseErrorPage_NoDbOrMigrationsTitle(object p0)
           => string.Format(Culture, GetResourceString("DatabaseErrorPage_NoDbOrMigrationsTitle"), p0);

        /// <summary>In Visual Studio, use the Package Manager Console to scaffold a new migration for these changes and apply them to the database:</summary>
        internal static string DatabaseErrorPage_PendingChangesInfoPMC => GetResourceString("DatabaseErrorPage_PendingChangesInfoPMC");
        /// <summary>There are pending model changes for {0}</summary>
        internal static string DatabaseErrorPage_PendingChangesTitle => GetResourceString("DatabaseErrorPage_PendingChangesTitle");
        /// <summary>There are pending model changes for {0}</summary>
        internal static string FormatDatabaseErrorPage_PendingChangesTitle(object p0)
           => string.Format(Culture, GetResourceString("DatabaseErrorPage_PendingChangesTitle"), p0);

        /// <summary>There are migrations for {0} that have not been applied to the database</summary>
        internal static string DatabaseErrorPage_PendingMigrationsInfo => GetResourceString("DatabaseErrorPage_PendingMigrationsInfo");
        /// <summary>There are migrations for {0} that have not been applied to the database</summary>
        internal static string FormatDatabaseErrorPage_PendingMigrationsInfo(object p0)
           => string.Format(Culture, GetResourceString("DatabaseErrorPage_PendingMigrationsInfo"), p0);

        /// <summary>Applying existing migrations for {0} may resolve this issue</summary>
        internal static string DatabaseErrorPage_PendingMigrationsTitle => GetResourceString("DatabaseErrorPage_PendingMigrationsTitle");
        /// <summary>Applying existing migrations for {0} may resolve this issue</summary>
        internal static string FormatDatabaseErrorPage_PendingMigrationsTitle(object p0)
           => string.Format(Culture, GetResourceString("DatabaseErrorPage_PendingMigrationsTitle"), p0);

        /// <summary>&gt; dotnet ef database update</summary>
        internal static string DatabaseErrorPage_ApplyMigrationsCommandCLI => GetResourceString("DatabaseErrorPage_ApplyMigrationsCommandCLI");
        /// <summary>The context type '{0}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped&lt;{0}&gt;() inside the UseServices(...) call in your application startup code.</summary>
        internal static string MigrationsEndPointMiddleware_ContextNotRegistered => GetResourceString("MigrationsEndPointMiddleware_ContextNotRegistered");
        /// <summary>The context type '{0}' was not found in services. This usually means the context was not registered in services during startup. You probably want to call AddScoped&lt;{0}&gt;() inside the UseServices(...) call in your application startup code.</summary>
        internal static string FormatMigrationsEndPointMiddleware_ContextNotRegistered(object p0)
           => string.Format(Culture, GetResourceString("MigrationsEndPointMiddleware_ContextNotRegistered"), p0);

        /// <summary>An error occurred while applying the migrations for '{0}'. See InnerException for details.</summary>
        internal static string MigrationsEndPointMiddleware_Exception => GetResourceString("MigrationsEndPointMiddleware_Exception");
        /// <summary>An error occurred while applying the migrations for '{0}'. See InnerException for details.</summary>
        internal static string FormatMigrationsEndPointMiddleware_Exception(object p0)
           => string.Format(Culture, GetResourceString("MigrationsEndPointMiddleware_Exception"), p0);

        /// <summary>The context type '{0}' could not be loaded. Ensure this is the correct type name for the context you are trying to apply migrations for.</summary>
        internal static string MigrationsEndPointMiddleware_InvalidContextType => GetResourceString("MigrationsEndPointMiddleware_InvalidContextType");
        /// <summary>The context type '{0}' could not be loaded. Ensure this is the correct type name for the context you are trying to apply migrations for.</summary>
        internal static string FormatMigrationsEndPointMiddleware_InvalidContextType(object p0)
           => string.Format(Culture, GetResourceString("MigrationsEndPointMiddleware_InvalidContextType"), p0);

        /// <summary>No context type was specified. Ensure the form data from the request includes a 'context' value, specifying the context type name to apply migrations for.</summary>
        internal static string MigrationsEndPointMiddleware_NoContextType => GetResourceString("MigrationsEndPointMiddleware_NoContextType");
        /// <summary>A database operation failed while processing the request.</summary>
        internal static string DatabaseErrorPage_Title => GetResourceString("DatabaseErrorPage_Title");
        /// <summary>Entity Framework did not record any exceptions due to failed database operations. This means the current exception is not a failed Entity Framework database operation, or the current exception occurred from a DbContext that was not obtained from request se ...</summary>
        internal static string DatabaseErrorPage_NoRecordedException => GetResourceString("DatabaseErrorPage_NoRecordedException");
        /// <summary>PM&gt; Add-Migration [migration name]</summary>
        internal static string DatabaseErrorPage_AddMigrationCommandPMC => GetResourceString("DatabaseErrorPage_AddMigrationCommandPMC");
        /// <summary>PM&gt; Update-Database</summary>
        internal static string DatabaseErrorPage_ApplyMigrationsCommandPMC => GetResourceString("DatabaseErrorPage_ApplyMigrationsCommandPMC");
        /// <summary>Alternatively, you can scaffold a new migration and apply it from a command prompt at your project directory:</summary>
        internal static string DatabaseErrorPage_NoDbOrMigrationsInfoCLI => GetResourceString("DatabaseErrorPage_NoDbOrMigrationsInfoCLI");
        /// <summary>Alternatively, you can scaffold a new migration and apply it from a command prompt at your project directory:</summary>
        internal static string DatabaseErrorPage_PendingChangesInfoCLI => GetResourceString("DatabaseErrorPage_PendingChangesInfoCLI");
        /// <summary>Alternatively, you can apply pending migrations from a command prompt at your project directory:</summary>
        internal static string DatabaseErrorPage_HowToApplyFromCLI => GetResourceString("DatabaseErrorPage_HowToApplyFromCLI");

    }
}