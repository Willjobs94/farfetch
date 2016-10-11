﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Farfetch.DTO;

namespace FarFetch.API
{
	public interface IBoutiqueAPI
	{
		Task<IEnumerable<BoutiqueItem>> GetAll();

		Task<Boutique> GetOne(int id);
	}
}