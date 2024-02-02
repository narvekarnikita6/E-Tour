package com.example.services;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entity.Booking_Header;

import com.example.entity.Category_Master;
import com.example.repositories.Category_MasterRepository;


@Service
public class Category_MasterManagerImpl implements Category_MasterManager {
 
	
	@Autowired
	Category_MasterRepository repository;

	@Override
	public void addCategory(Category_Master c) {
		repository.save(c);
		
	}

	@Override
	public List<Category_Master> getAllCategory() {
		return repository.findAll();
	}

	@Override
	public void delete(int id) {
		
		repository.deleteById(id);
	}

	@Override
	public Optional<Category_Master> getCategory(int id) {
	
		return repository.findById(id);
	}

//	@Override
//	public void update(Category_Master cmaster, int id) {
//		repository.update(cmaster.getCat_name(),cmaster.getCatimagepath(),cmaster.getSubcat_id(),cmaster.getCat_id(),id);
//		
//	}

	@Override
	public List<String> findBycatId(String catId) {
		// TODO Auto-generated method stub
		return repository.findBycatId(catId);
	}
	
	@Override
	public List<Category_Master> findBysubCatId(String subCatId) {
		// TODO Auto-generated method stub
		return repository.findBysubCatId(subCatId);
	}

	@Override
	public List<String> findAllDistinctCatIds() {
		// TODO Auto-generated method stub
		return repository.findAllDistinctCatIds();
	
//		List<Category_Master> categories = new ArrayList<>();
//
//        for (Category_M dto : cat) {
//            Category_Master category = new Category_Master();
//            category.setCatId(dto.getCatId());
//            category.setCatImagePath(dto.getCatImagePath());
//            categories.add(category);
//        }
//
//        return categories;
	}

	@Override
	public List<String> findAllDistinctsubCatIds() {
		// TODO Auto-generated method stub
		return repository.findAllDistinctsubCatIds();
	}

	@Override
	public List<Category_Master> findByCatName(String name) {
		// TODO Auto-generated method stub
		return repository.findBysubCatId(name);
	}

	@Override
	public Optional<Category_Master> getCategoryById(int catMasterId) {
        return repository.findById(catMasterId);
    }
	
}
