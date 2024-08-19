using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        int answer = 0;
        var queue = new Queue<(int x, int y)>();
        var dirs = new (int x, int y)[4]{(-1,0), (1,0), (0,-1), (0,1)};
        
        int width = maps.GetLength(0);
        int height = maps.GetLength(1);
        
        queue.Enqueue((0,0));
        
        while(queue.Count > 0)
        {
            var curPos = queue.Dequeue();
            
            foreach(var dir in dirs)
            {
                (int x, int y) t = (curPos.x + dir.x, curPos.y + dir.y);
                if(t.x < 0 || t.x >= width || t.y < 0 || t.y >= height) continue;
                if(maps[t.x,t.y] != 1) continue;
                
                queue.Enqueue(t);
                maps[t.x, t.y] = maps[curPos.x,curPos.y] + 1;
            }
        }
        
        if(maps[width-1, height -1] == 1) return -1;
        else return maps[width-1, height -1];
        
    }
}