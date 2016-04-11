structureType = 1

-- BuildTile(x, y, tiletype)
if structureType == 1 then
	
	BuildTile(0,0,60)
	BuildTile(0, -1, 63)
	BuildTile(0, 1, 66)
	BuildTile(1,0, 64)
	BuildTile(-1, 0, 65)
	BuildTile(1,1, 67)
	BuildTile(-1, 1, 68)
	BuildTile(-1, -1, 62)
	BuildTile(1, -1, 61)
	
	end

if structureType == 2 then
	
	BuildTile(0,0,20)
	BuildTile(0, -1, 20)
	BuildTile(0, 1, 20)
	BuildTile(1,0, 20)
	BuildTile(-1, 0, 20)
	BuildTile(1,1, 20)
	BuildTile(-1, 1, 20)
	BuildTile(-1, -1, 20)
	BuildTile(1, -1, 20)
	
	end
	
