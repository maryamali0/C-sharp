   M S B A M L   `   `   `  ����D  @Proj2-Ali, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Proj2_Ali	Proj2_Ali  5   	       Proj2_Ali.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Proj2_Ali     5   	     � Title$  Maryam's Burger Shack��5   	   $	��600��6'   $	��800��64   .��5	      � {�. ���	#FFFBAC4C J� RenderTransformOrigin$ 0.542,0.582&�63   $	��644��6W   $	��Top=�6d    � RowDefinitions 5
   
   �� 5      $
��145* �6   �� 5      $	��16* �6   .+�5   
   �� $��Maryam's Burger Shack��6   $
��Left=�60   $��
267,14,0,0q�6K   $	��Top=�6_   $��MV Boli)�6w   $��24(�6�   ���	#FF2374E86�   �� 5   
   $�� ��6   $
��Left=�6   $	��112��68   $	��Top=�6E   $	��196��6]   $��	43,46,0,0q�6i   .��5      �� $
��Left=�6   $��81��64   $��	10,10,0,0q�6@   $	��Top=�6S   $	��288��6k   .+�5      �� $��Patty Type:��6   $��	0,0,207,0q�6.   $��MV Boli)�6A   $
��Bold"�6V   	� 5      -   5         	�Name$ radBeef��5      $��
Spicy Beef��6/    d� 	IsChecked$
 TrueY�6b   $��Comic Sans MS)�6s   	� 5      -   5        $ 
radChicken��5      $��Garlic Chicken��62   $��Comic Sans MS)�6k   	� 5      -   5        $ radBeans��5      $��Potato and Beans��60   $��Comic Sans MS)�6k   5      5      �� 5   
   $��Extra Patties?
��6   $
��Left=�63   $��
43,179,0,0q�6N   $	��Top=�6b   $��25��6z   $��MV Boli)�6�   $
��Bold"�6�   �� 5   
   $��$0.50c each
��6   $
��Left=�60   $��
43,200,0,0q�6K   $	��Top=�6_   $��24��6w   $��10(�6�   $��Helvetica Neue for SAS)�6�   �� 5   
   -   5         ��Name$ sldPatty��5      $
��Left=�6#   $��143,189,0,0q�6>   $	��Top=�6S   $	��201��6k    � Maximum$ 3Q�6w    �� TickFrequency$ 3Q�6�    � SmallChange$ 1Q�6�   	 �� IsSnapToTickEnabled	 . 
 �� TickPlacement$
 BottomRight=�6�    �� AutoToolTipPlacement$ BottomRight=�6�    �� Ticks$ 0 1 2 3R�6"  �� 5   
   -   5         ��Name$ lblExtraPatties��5      $��0��6)   $
��Left=�65   $��233,206,0,0q�6P   $	��Top=�6e   �� 5   
   $��Toppings:

��6   $
��Left=�63   $��
43,275,0,0q�6N   $	��Top=�6b   $��37��6z   $��MV Boli)�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��42��60   $	��Top=�6<   $	��114��6T   $��106,275,0,0q�6`   .+�5      �� -   5         ��Name$ 	chkCheese��5      $��Cheese��6*   $��Comic Sans MS)�6W   �� 5      -   5        $ 
chkPickles��5      $��Pickles ($1.00)��6+   $��Comic Sans MS)�6�   5      �� 5    
   $��	Other:

��6   $
��Left=�60   $��
43,317,0,0q�6K   $	��Top=�6_   $��58��6w   $��28��6�   $��MV Boli)�6�   $
��Bold"�6�   �� 5!   
   -   5         ��Name$ txtOther��5!      $
��Left=�6$   $��23��6?   $��106,322,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   .��6�   5#      �� 5%   
   $��
Beverage: ��6   $
��Left=�6%   $��
43,357,0,0q�6@   $	��Top=�6T   $��MV Boli)�6l   $
��Bold"�6�   �� 5&   
   -	   5         ��Name$ cboBeverage��5&      $
��Left=�6(   $��106,361,0,0q�6C   $	��Top=�6X   $	��120��6p   4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm .  �� SelectedIndex$ 0��6�   .@�5'      �� $
��Coke��6   �� 5(      $��Sprite��6   �� 5)      $��Orange Juice��6   5*      �� 5+   
   -
   5        $ lblInitialCost��5+      $�� ��6(   $
��Left=�63   $��147,455,0,0q�6N   $	��Top=�6c   
���  ��6{   �� 5,   
   -   5        $ lblBeverage��5,      $��Cost: ��6%   $
��Left=�66   $��
43,455,0,0q�6Q   $	��Top=�6e   $��Helvetica Neue for SAS)�6}   �� 5-   
   -   5         ��Name$ btnConfirmOrder��5-   )   $��Confirm Order��6   $
��Left=�6B   $��122,497,0,0q�6]   $	��Top=�6r   $��89��6�   ���	#FF2374E8
�������6�   �� 5.   
   $��Your Name:
��6   $
��Left=�6*   $��
43,407,0,0q�6E   $	��Top=�6Y   $ -4.442,0.658&�6q   $��MV Boli)�6�   $
��Bold"�6�   �� 5/   
   -   5        $ txtName��5/      $
��Left=�6#   $��23��6>   $��129,407,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   6�   �� 50   
   $��Base cost is $4.00
��6   $
��Left=�67   $��
345,57,0,0q�6R   $	��Top=�6f   $	��111��6~   $��Helvetica Neue for SAS)�6�   �� 51   
   $��Potato and Beans��6   $
��Left=�6+   $��563,386,0,0q�6F   $	��Top=�6[   $��Segoe UI Black)�6s   ���	#FF88788D6�   �� 52   
   $��Garlic Chicken��6   $
��Left=�6)   $��573,212,0,0q�6D   $	��Top=�6Y   $��Segoe UI Black)�6q   ���	#FF88788D6�   �� 53   
   $��
Spicy Beef��6   $
��Left=�6%   $��
573,51,0,0q�6@   $	��Top=�6T   $��Segoe UI Black)�6l   ���	#FF8A788D6�   �� 54   
   $
��Left=�6   $	��123��6+   $��
537,84,0,0q�68   $	��Top=�6L   $	��151��6d   $��SpicyBeef.jpg��6p   $
��Fill=�6�   �� 55   
   $
��Left=�6   $	��123��6+   $��537,243,0,0q�68   $	��Top=�6M   $	��151��6e   $
��Fill=�6q   $��Chicken.jpg��6�   �� 56   
   $
��Left=�6   $	��123��6+   $��537,417,0,0q�68   $	��Top=�6M   $	��151��6e   $
��Fill=�6q   $��PotatoAndBeans.jpg��6�   58      59      