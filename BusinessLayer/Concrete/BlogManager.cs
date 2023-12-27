﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogRemove(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAllBlogs()
		{
			return _blogDal.GetAll();
		}

		public Blog GetBlogById(int id)
		{
			return _blogDal.GetByID(id);
		}

		public List<Blog> GetBlogsWithCategory()
		{
			return _blogDal.GetBlogsWithCategories();
		}
	}
}
