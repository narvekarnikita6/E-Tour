package com.example.services;

import java.util.List;
import java.util.Optional;

import com.example.entity.Cost_Master;
import com.example.entity.Itinerary_Master;
import com.example.repositories.Cost_Masterrepository;

public interface Cost_Master_Services {
	void addCost(Cost_Master t);
	List<Cost_Master> getCost();
	void delete(int id);
	//void update(Cost_Master cost,int id);
	Optional<Cost_Master> getById(int id);
	List<Cost_Master> findBypkgId(int pkgId);
	List<Cost_Master> getCostsByCostLessThanEqual(int cost);
}