package com.example.services;

import java.util.List;
import java.util.Optional;

import com.example.entity.Booking_Header;

import com.example.entity.Category_Master;

public interface Category_MasterManager {

	 void addCategory(Category_Master category);
	 List<Category_Master> getAllCategory();
	 void delete(int id);
     //void update(Category_Master cmaster,int id);
	 Optional<Category_Master> getCategory(int id);
	 List<String> findBycatId(String catId);
	 List<Category_Master> findBysubCatId(String subCatId);
	 public List<String> findAllDistinctCatIds(); 
	 public List<String> findAllDistinctsubCatIds();
	 public Optional<Category_Master> getCategoryById(int catMasterId);
	 List<Category_Master> findByCatName(String name); 
}