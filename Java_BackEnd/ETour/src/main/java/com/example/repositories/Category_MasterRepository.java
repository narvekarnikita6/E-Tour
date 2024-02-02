package com.example.repositories;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;


import com.example.entity.Category_Master;

import jakarta.transaction.Transactional;

@Repository
@Transactional
public interface Category_MasterRepository extends JpaRepository<Category_Master, Integer> {
	@Query(value = "SELECT sub_cat_id FROM Category_Master where cat_id = :cat_id GROUP BY sub_cat_id", nativeQuery = true)
    public List<String> findBycatId(@Param("cat_id")String catId);
    
    public List<Category_Master> findBysubCatId(String subCatId);

    @Query(value = "SELECT cat_Id FROM Category_Master GROUP BY cat_Id", nativeQuery = true)
    public List<String> findAllDistinctCatIds(); // Assuming cat_id is a String
    
    @Query(value = "SELECT sub_cat_id FROM Category_Master GROUP BY sub_cat_id", nativeQuery = true)
    public List<String> findAllDistinctsubCatIds(); // Assuming cat_id is a String
    // Add other methods as needed
}
