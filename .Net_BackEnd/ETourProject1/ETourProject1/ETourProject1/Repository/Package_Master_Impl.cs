using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ETourProject1.Repository
{

    public class Package_Master_Impl : IPackage_Master_Interface
    {
        private readonly Appdbcontext context;
        public async Task<ActionResult<Package_Master>?> AddPackage(Package_Master package)
        {
            context.PackageMaster.Add(package);
            await context.SaveChangesAsync();
            return package;
        }



        

        public async Task<ActionResult<Package_Master>?> GetById(int id)
        {
            if (context.PackageMaster == null)
            {
                return null;
            }
            var package = await context.PackageMaster.FindAsync(id);
            if (package == null)
            {
                return null;
            }
            return package;
        }

        public async Task<ActionResult<IEnumerable<Package_Master>>> GetPackageMasters()
        {

            if (context.PackageMaster == null)
            {
                return null;
            }

            return await context.PackageMaster.ToListAsync();
        }


        private bool PackageExists(int id)
        {
            return (context.PackageMaster?.Any(e => e.PkgId == id)).GetValueOrDefault();
        }
    }
}
