   M S B A M L   `   `   `  ����D  @Mine_Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Mine_Game	Mine_Game  5   	       Mine_Game.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Mine_Game     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � -   5        $��gr��5	      .+�5
   
   �� -   5         ��Name$ bt_Start��5
      $��Start��6#   $
��Left=�63   $��217,236,0,0q�6N   $	��Top=�6c   $��92��6{   $��34��6�   $
��Bold"�6�   $��18(�6�   6�   �� 5   
   -   5         ��Name$ sliderX��5       � Minimum$ 10Q�6"    � Maximum$ 30Q�6/    �� IsSnapToTickEnabled .  �� TickFrequency$ 5Q�6W   $
��Left=�6i   $��
232,41,0,0q�6�   $	��Top=�6�   $��20��6�   $	��227��6�   �� 5   
   -   5        $ sliderY��5      $ 10Q�6"   $ 20Q�6/    . $ 5Q�6W   $
��Left=�6i   $��232,110,0,0q�6�   $	��Top=�6�   $	��227��6�   �� 5   
   -   5        $ sliderM��5      $ 10Q�6"   $ 95Q�6/    . $ 10Q�6W   $
��Left=�6j   $��232,174,0,0q�6�   $	��Top=�6�   $	��227��6�   �� 5   
   -   5         ��Name$ label1��5      $��Table Size Y��6    $
��Left=�67   $��
43,102,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ label��5      $��Table Size X��6   $
��Left=�66   $��	43,41,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5        $ label1_Copy��5      $��Mines��6%   $
��Left=�65   $��
43,166,0,0q�6P   $	��Top=�6d   �� 5   
   -	   5        $ label2��5      $
��Left=�6S   $��
142,41,0,0q�6n   $	��Top=�6�   ��6    ��  �� ElementName$ sliderX��	 �� Path$	 Value�6�   �� 5   
   -
   5        $ label3��5      $
��Left=�6S   $��142,102,0,0q�6n   $	��Top=�6�   ��6    �� $ sliderY��$	 Value�6�   �� 5   
   -   5        $ label4��5      $
��Left=�6S   $��142,166,0,0q�6n   $	��Top=�6�   ��6    �� $ sliderM��$	 Value�6�   5      5      