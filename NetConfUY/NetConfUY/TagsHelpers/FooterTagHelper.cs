using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NetConfUY.TagsHelpers
{
    [HtmlTargetElement("footer")]
    public class FooterTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.Content.AppendHtml(@"
               <div class='row'>

                    <div class='col-sm-5'>
                        &copy; 2017 <a href='http://http://www.netconf.uy'>NetConfUY</a> by David Revoledo
                    </div>

                    <div class='col-sm-7 text-right'>
                        Powered by: <a href='http://http://www.netconf.uy' alt='David Revoledo'>David Revoledo</a> | NETCONF UY
                    </div>

                </div>
            ");
        }
    }
}
