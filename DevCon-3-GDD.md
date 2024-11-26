# Game Design Document: *Reverse Brick-Breaker*

## **1. Overview**  
**What are we making?**  
We are creating *Reverse Brick-Breaker*, a game where players drop randomized balls through a pachinko-style board to break layers of bricks at the bottom.  

**Game Modes**:  
- **Easy**: Break 2 layers of bricks.  
- **Hard**: Break 4 layers of bricks.  

**Objective**:  
Break all the brick layers before running out of balls. If you run out of balls, you lose the game.  

---

## **2. Objective Statement**
**What question are you trying to answer with your prototype? Why?**  


---

## **3. Design Rationale**
- **What do you envision?**  

- **How is the game experience informed by metrics?**  

- **How is it engaging beyond a simulation?**  

---

## **4. Metric Research and References**
What real-world information are you leveraging to inform object scale, weight, friction, etc.? 

---

## **5. Citations**
Cite all resources used in planning and development:  

---

## **6. Additional Sections**

### **Ball Types and Properties**
Each ball has unique gameplay properties:  
- **Tennis Ball**:  
  - Can be clicked once to apply extra force.  
  - Medium weight and bounce.  
- **Cannonball**:  
  - Heavy, falls quickly, minimal bounce.  
- **Glass Ball**:  
  - Breaks on high impact, limited durability.  
- **Rubber Ball**:  
  - High bounce, weaker against bricks.  
- **Metal Ball**:  
  - Interacts with magnets or is drawn toward metal bricks.  
- **Average Ball**:  
  - Balanced properties for standard performance.  
- **Split Ball**:  
  - Breaks into smaller balls upon impact, causing less damage but increasing coverage.  

---

### **Difficulty and Gameplay Flow**
1. **Setup**:  
   - Players start with a maximum of 20 balls.  
   - The goal is to break all bricks at the bottom.

2. **Gameplay Flow**:  
   - Players drop randomized balls through the pachinko board to break brick layers.  
   - The game has two modes: **Easy** (2 layers of bricks) and **Hard** (4 layers of bricks).  

3. **Player Interaction**:  
   - Players strategically drop balls, aiming to break all bricks before running out of balls.  

