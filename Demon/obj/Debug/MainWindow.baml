   M S B A M L   `   `   `  ����@  <Demon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DemonDemon  5   	       Demon.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   #srcclr-namespace:Demon     5   	     � Title$  交通仿真演示程序��5   	   $	��500��6   $	��800��6'   .��5      � .+�5   
   	� $��动态仿真��6   $��	0,26,56,0q�6&   $��Right=�69   $��64��6U   $��16��6`   $	��Top=�6l   	� 5   
   $��静态仿真��6   $��	0,72,56,0q�6&   $��16��69   $	��Top=�6E   $��Right=�6]   $��64��6y   �� 5	   
   -   5        $��开始仿真��5	      $��
0,0,45,102q�6!   $��Right=�65   $��75��6Q   $��22��6\   $��Bottom=�6h   6�   �� 5
   
   -   5        $��停止仿真��5
      $��	0,0,45,57q�6!   $��22��64   $��Bottom=�6@   $��Right=�6[   $��75��6w   6�   �� 5   
   -   5         ��Name$ MapGroup��5      $��Stretch=�6%   $��Stretch=�6H   $��	0,0,163,0q�6m   .��5        Demon.MapControl  -   5          Name$ 
mapControl��5      c _GMap.NET.WindowsPresentation, Version=1.7.0.0, Culture=neutral, PublicKeyToken=b85b9027b614afef.  (GMap.NET.WindowsPresentation.GMapControl   Zoom$ 13Q�61      MaxZoom$ 24��6;      MinZoom$ 1��6H   5      �� 5   
   -   5         ��Name$ TbOfType��5      $
��Left=�6%   $��23��6@   $��662,144,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $��对象��6u   $	��Top=�6   $	��120��6�   �� 5   
   -   5        $ TbOfID��5      $
��Left=�6#   $��23��6>   $��662,183,0,0q�6J   $
 Wrap=�6_   $��编号��6s   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ 
TbOfLatlng��5      $
��Left=�6&   $��56��6A   $��662,224,0,0q�6M   $
 Wrap=�6b   $��坐标��6v   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ TbOfDraw��5      $
��Left=�6%   $��651,103,0,0q�6@   $	��Top=�6U   $	��120��6m   .@�5      �� $��	不绘制��6   $
��Left=�6)   $	��118��6D   �� 5      $��绘制的士��6   $
��Left=�6*   $	��118��6E   �� 5      $��绘制乘客��6   $
��Left=�6*   $	��118��6E   5      5      5      