/** 
	 * JQuery扩展方法，用户对JQuery EasyUI的DataGrid控件进行操作。 
	 */  
	$.fn.extend({
	    /** 
	     * 添加DataGrid对象的自动填充方法，以适应页面高度。 
	     *  
	     * @param id 操作的datagrid的id 
	     *             
	     * @param minRows 保持最小行数
	     *  
	     */  
	    fillBlankRowsDataGrid : function(id,minRows) {
	        //var data=$("#"+id).datagrid('getData');
	        var len =$("#"+id).datagrid('getRows').length;
	        if(!minRows){
	            minRows = 0;
	        }
			 // var len = data.total;
			  if(len<minRows){
			 
			   var xhbody = $("#"+id).parent().children(".datagrid-view1").children(".datagrid-body").children(".datagrid-body-inner").children(".datagrid-btable").children("tbody");
			   var nrbody = $("#"+id).parent().children(".datagrid-view2").children(".datagrid-body").children(".datagrid-btable").children("tbody");
			  // nrbody.
			  var headfield = $("#"+id).parent().children(".datagrid-view2").children(".datagrid-header").children(".datagrid-header-inner").children(".datagrid-htable").children("tbody").children("tr").children("[field]");
			  var colsarr = [];
			  var opt;
			  var obj;
			  headfield.each(function(){
			      opt = $(this).attr("field");
			      colsarr.push(opt);
			  });
			  
			  /*$("#"+id+" thead [data-options]").each(function(){
			      opt = $(this).attr("data-options");
			      if(opt &&opt.indexOf(":")>0){
			          obj = eval(opt);
			          opt = obj["field"];
			          if(opt&&opt!=""){
			              colsarr.push(opt);
			          }
			      }
			      
			  });*/
			  
		
			      if(colsarr &&colsarr.length){
					 var arrs = [];
					 var str ;
					 var n = len;
			      for(var i=minRows;i>len;i--){
			          str = "";
				      //$('#dg').datagrid('appendRow',{});
				      //对序号列的处理
					   $('<tr class="datagrid-row" style="height:25px" datagrid-row-index="'+n+'"><td class="datagrid-td-rownumber">&nbsp;</td></tr>').appendTo(xhbody);
					 //对内容列的
					 
					 str +='<tr class="datagrid-row" style="height:25px" datagrid-row-index="'+n+'">';
					 for(var j=0;j<colsarr.length;j++){
					     str +='<td><div class="datagrid-cell  datagrid-cell-c2-'+colsarr[j]+'" style="height:auto;">&nbsp;</div></td>';
					 }
					 str +='</tr>';
					 $(str).appendTo(nrbody);
					 n++;
					 }
					  //$('<tr class="datagrid-row" style="height:25px" datagrid-row-index="0"><td><div class="datagrid-cell  datagrid-cell-c2-SSUMMARY" style="height:auto;"></div></td><td><div class="datagrid-cell  datagrid-cell-c2-SYSTEMID" style="height:auto;"></div></td><td><div class="datagrid-cell datagrid-cell-c2-SENDERNAME" style="height:auto;"></div></td><td><div class="datagrid-cell datagrid-cell-c2-SENDERDEPTNAME" style="height:auto;"></div></td><td><div class="datagrid-cell datagrid-cell-c2-RECEIVERTIME" style="height:auto;"></div></td><td><div class="datagrid-cell datagrid-cell-c2-TIMEOUTTIME" style="height:auto;"></div></td><td><div class="datagrid-cell datagrid-cell-c2-BY2" style="height:auto;"></div></td></tr>').appendTo(nrbody);
				  }
			  }
		
    	}  
	});